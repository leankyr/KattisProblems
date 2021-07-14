f = open("/home/leankyr/Downloads/fyi/a001.in", 'r', encoding='utf-8')

l = f.readline()

if l[0] == l[1] == l[2] == '5':
    print(1)
else:
    print(0)


f.close()