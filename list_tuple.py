list1=[1,2,3,4,5,6]
print(list1[0])
print(list1[-1])
print(len(list1))
nums = [10, 20, 30, 40, 50]
i=nums.index(30)
nums[i]=35
print(nums)
nums[1]=22
print(nums)
a=int(input("enter the element"))
if a in list1:
    print("yes")
else:
    print("no")