f = open("/home/leankyr/Downloads/ratingproblems/rating-0001.in", 'r', encoding='utf-8')

l = f.readline()
ll = l.split()
n = int(ll[0])
k = int(ll[1])

s = 0
for _ in range(k):
    l = f.readline()
    v1 = int(l)
    s += v1

smin = s
smax = s

maxgrade = 3

for _ in range(n - k):
    smin += -maxgrade
    smax += maxgrade

print(smin/n, smax/n)

f.close()
