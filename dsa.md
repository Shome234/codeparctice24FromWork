bubble sort =swapping the valuses side by side according to value
```py
my_array = [64, 34, 25, 12, 22, 11, 90, 5]

def bubble(arr):
  for i in range(len(arr)-1):
    for j in range(len(arr)-i-1):
      if arr[j]>arr[j+1]:
        arr[j],arr[j+1]=arr[j+1],arr[j]
        print(arr)

bubble(my_array)
print("sorted- ",my_array)
```
selection sort= inserting a value at right index after finding the smallest value
```py
my_array = [64, 34, 25, 12, 22, 11, 90, 5]

def selection(arr):
  for i in range(len(arr)-1):
    min_idx=i
    for j in range(i+1,len(arr)):
      if arr[j]<arr[min_idx]:
      	min_idx=j
    min_val=arr.pop(min_idx)
    arr.insert(i,min_val)
    print(arr)

selection(my_array)
print("sorted- ",my_array)
```
insertion sort=inserting a value at a right index after comparing with the next value
```py
my_array = [64, 34, 25, 12, 22, 11, 90, 5]

def insertion(arr):
  for i in range(1,len(arr)):
    insert_idx=i
    curr_val=arr.pop(insert_idx)
    for j in range(i-1,-1,-1):
      if arr[j]>curr_val:
      	insert_idx=j
    arr.insert(insert_idx,curr_val)
    print(arr)

insertion(my_array)
print("sorted- ",my_array)
```
