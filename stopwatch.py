f = open("/home/leankyr/Downloads/stopwatch/3.in", 'r', encoding='utf-8')

l = f.readline()
n = int(l)

if n % 2 == 1:
    print("still running")
else:
    s = 0
    for _ in range(n//2):
        l = f.readline()
        v1 = int(l)
        l = f.readline()
        v2 = int(l)
        s += v2 - v1

    print(s)

f.close()