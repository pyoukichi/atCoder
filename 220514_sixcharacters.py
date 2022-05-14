
string = input()
res = ""
if len(string)==1:
    for i in range(6):
        res += string
elif len(string)==2:
    for i in range(3):
        res += string
else :
    for i in range(2):
        res += string
print(res)
