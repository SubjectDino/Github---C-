print("Anonymous Income Comparison Program")

print("Person 1")
hourly_rate_person1 = float(input("Hourly Rate? "))
hours_per_week_person1 = float(input("Hours worked per week? "))

print("Person 2")
hourly_rate_person2 = float(input("Hourly Rate? "))
hours_per_week_person2 = float(input("Hours worked per week? "))
annual_salary_person1 = hourly_rate_person1 * hours_per_week_person1 * 52
annual_salary_person2 = hourly_rate_person2 * hours_per_week_person2 * 52

print(f"Annual salary of Person 1:\n{annual_salary_person1}")
print(f"Annual salary of Person 2:\n{annual_salary_person2}")
makes_more = annual_salary_person1 > annual_salary_person2

print("Does Person 1 make more money than Person 2?")
print(makes_more)