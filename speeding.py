f = open("/home/leankyr/Downloads/speeding/2.in", 'r', encoding='utf-8')


n = f.readline()

l = f.readline()
ll = l.split(" ")

li = map(int, ll)
li = list(li)

h0 = li[0]
d0 = li[1]

maxV = 0
for _ in range(int(n) - 1):
    l = f.readline()
    ll = l.split(" ")

    li = map(int, ll)
    li = list(li)

    h1 = li[0]
    d1 = li[1]

    v = (d1 - d0)/(h1 - h0)

    if v > maxV:
        maxV = v

    h0 = h1
    d0 = d1

print(int(maxV))

