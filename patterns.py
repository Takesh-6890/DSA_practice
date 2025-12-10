#simple horizontal line
#n can taken from user by : n=int(input("enter the number"))
n=5
print("*"*n)
#methond 2
n=5
for i in range(n):
    print("*",end='')
#simple vertical line
n=5
for i in range(n):
    print("*")
#square
n=5
for i in range(n):
    for j in range(n):
        print('*',end=' ')
    print()
#increasing triangle 
n=5
for i in range(n):
    for j in range(i+1):
        print('*',end=' ')
    print()
print(" ")
#decreasing triangle
n=5
for i in range(n):
    for j in range(i,n):
        print('*',end=' ')
    print()
#right lower triangle
print(" ")
n=5
for i in range(n):
    for j in range(i,n):
        print(" ",end=" ")
    for k in range(i+1):
        print('*',end=" ")
    print()
#right upper triangle
print("")
n=5
for i in range(n):
    for j in range(i+1):
        print(' ',end=' ')
    for j in range(i,n):
        print('*',end=' ')
    print()

    print(" ")
n = 5

for i in range(n):
    # print spaces
    for j in range(i):
        print("  ", end="")
        
    # print stars
    for j in range(n - i):
        print("* ", end="")
        
    print()


#hill pattern
n=5
for i in range(n):
    for j in range (i,n):
        print(" ",end=' ')
    for j in range(i):
        print('*',end=' ')
    for j in range(i+1):
        print('*',end=' ')
    print()