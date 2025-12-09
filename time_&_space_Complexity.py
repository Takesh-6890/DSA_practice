#it runs n times -->o(n)
for i in range(3):
    print(i)

#it runs n^2 times -->o(n^2)
for i in range(3):
    for j in range(4):
        print(i,j)
#O(1) space
sum=0
for i in range(n):
    sum+=i
#O(n) space
arr=[i]
for i in range(n):
    arr.append(i)               