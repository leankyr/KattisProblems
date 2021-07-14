import math

f = open("/home/leankyr/Downloads/jackolanternjuxtaposition/sample003.in", 'r', encoding='utf-8')

l = f.readline()
ll = l.split(" ")

li = map(int, ll)
li = list(li)

prod = math.prod(li)

print(prod)


f.close()
