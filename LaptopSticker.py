f = open("/home/leankyr/Downloads/laptopsticker/sticker-0000.in", 'r', encoding='utf-8')

l = f.readline()
ll = l.split(" ")

li = map(int, ll)
li = list(li)

if li[0] - li[2] >= 2 and li[1] - li[3] >= 2:
    print(1)
else:
    print(0)

f.close()
