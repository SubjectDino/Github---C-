age = int(input("Please input your age. "))
dui = input("Have you ever had a DUI? (t/f) ").lower() == "true"
speeding_tickets = int(input("How many speeding tickets have you had? "))
qualified = age > 15 and not dui and speeding_tickets <= 3

print("Qualified?")
print(qualified)