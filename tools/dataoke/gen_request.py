import os
import re


def to_up_camel(name):
    s = re.sub('_([a-z-A-Z])', lambda m: (m.group(1).upper()), name)
    return s[0].upper() + s[1:]


def gen_request_property(name, summary):
    # /// <summary>
    # ///   order_ids String  否   订单id，多个以,连接
    # /// </summary>
    # [JsonProperty("order_ids")]
    # public string OrderIds { get; set; }

    name = name.strip()
    summary = [item.strip() for item in summary]

    result = []

    result.append("/// <summary>")
    result.append('/// {}'.format(' '.join(summary)))
    result.append("/// </summary>")
    result.append('[JsonProperty("{}")]'.format(name))
    result.append('public string {} {{ get; set; }}'.format(to_up_camel(name)))
    result.append('')
    return result


def gen_request(lines=4):
    path = os.path.join(os.path.dirname(__file__), 'source.txt')
    temp = []
    result = []
    with open(path, 'r', encoding='utf8') as f:
        while True:
            line = f.readline()
            if not line:
                break
            temp.append(line)
            if len(temp) == lines:
                p = gen_request_property(temp[0], temp)
                result.extend(p)
                temp.clear()
    path = os.path.join(os.path.dirname(__file__), 'output.txt')
    with open(path, 'w', encoding='utf8') as f:
        f.write("#region\n")
        f.write('\n')
        for l in result:
            f.write(l)
            f.write('\n')

        f.write("#endregion")


if __name__ == "__main__":
    gen_request()
