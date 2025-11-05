pesel = input("Enter pesel: ")

while len(pesel) !=11:
    print("POdaj dobrą ilość znaków")
    pesel = int(input("Enter pesel: "))
while not pesel.isdigit():
    print("pesel musi skladac sie z cyfr")
    pesel = int(input("Enter pesel: "))

def checkGender(pesel):
    if int(pesel[9])%2==0:
        return "K"
    return "M"

def checkSum(pesel):
    wagi = "1379137913"
    s=0
    for i in range(len(wagi)):
        s+= (int(pesel[i])*int(wagi[i]))
        print(s, pesel[i], wagi[i])

    m=s%10
    print(m)
    if m==0:
        r=0
    else:
        r=10-m
    if r == int(pesel[10]):
        return True
    return False

print(checkGender(pesel))
print(checkSum(pesel))

