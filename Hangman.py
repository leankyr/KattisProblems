f = open("/home/leankyr/Downloads/hangman/sample1.in", 'r', encoding='utf-8')

w = f.readline()
g = f.readline()

ww = w

missplays = 0

for c in g:
    if c in w:
        ww = ww.replace(c, '')
    else:
        missplays += 1

    if len(ww) == 1:
        print("WIN")
        break
    elif missplays == 10:
        print("LOSE")
        break

f.close()
