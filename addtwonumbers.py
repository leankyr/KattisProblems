f = open("/home/leankyr/Downloads/addtwonumbers/1.in", 'r', encoding='utf-8')

l = f.readline()
ll = l.split(" ")

li = map(int, ll)
li = list(li)

print(sum(li))


f.close()