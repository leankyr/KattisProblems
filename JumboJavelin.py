f = open("/home/leankyr/Downloads/jumbojavelin/01.in", 'r', encoding='utf-8')

l = f.readline()
ll = l.split()
n = int(ll[0])


s = 0
for _ in range(n):
    l = f.readline()
    v1 = int(l)
    s += v1

s = s - (n - 1)

print(s)

f.close()
