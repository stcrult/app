def flatten(data, l):
    for i in data:
        if type(i) == list:
            flatten(i, l)
        else:
            l.append(i)

def reverse(data):
    for i in range(0, len(data) // 2):
        if type(data[i])==list:
            reverse(data[i])
        z = data[i]
        data[i] = data[len(data)-i-1]
        if type(data[i])==list:
            reverse(data[i])
        data[len(data)-i-1] = z

    
l= []
data = [[1,'a',['cat'],2],[[[3]],'dog'],4,5]
flatten(data, l)
print("Flatten")
print("Input  = ",data)
print("Output =",l)
print()

data = [[1, 2], [3, 4], [5, 6, 7], 4]
print("Reverse:")
print("Input  =",data)
reverse(data)
print("Output =",data)
