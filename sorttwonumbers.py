f = open("/home/leankyr/Downloads/sorttwonumbers/2.in", 'r', encoding='utf-8')

l = f.readline()
ll = l.split(" ")

li = map(int, ll)
li = list(li)

ls = sorted(li)
for n in ls:
    print(n, end=" ")

f.close()