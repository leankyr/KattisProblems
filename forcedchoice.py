f = open("/home/leankyr/Downloads/forcedchoice/1.in", 'r', encoding='utf-8')

l = f.readline()
ll = l.split(" ")

li = map(int, ll)
li = list(li)


N = li[0]
P = li[1]
S = li[2]

for _ in range(S):
    l = f.readline()
    ll = l.split(" ")

    li = map(int, ll)
    li = list(li)

    length = li[0]
    li.remove(li[0])
    if P in li:
        print("KEEP")
    else:
        print("REMOVE")

f.close()
