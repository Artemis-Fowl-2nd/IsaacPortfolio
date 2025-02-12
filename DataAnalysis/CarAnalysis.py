import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns

data = pd.read_csv("car_price_dataset.csv")

print(data.Engine_Size.mean())

print(data.head(10))

#Some simple questions this data raises: How much does every mile change the price of a car? How much does each owner add to the milage of a car? 
#Which fuel type is most expensive?


sns.boxplot(x="Fuel_Type", y="Price", data=data)
plt.title("Boxplot of Price by Fuel Type")
plt.show()
#Looking at the chart, it seems that on average electric cars are the most expensive.


sns.regplot(x="Mileage", y="Price", data=data, scatter=True, line_kws={"color": "red"})  
print(np.polyfit(x=data.Mileage,y=data.Price, deg=1))
plt.show()
# This chart shows the relationship between price and mileage. Unsuprisingly, cars lose value as they get more miles.
# The calculation shows that, on average, a car will lose .0198 dollars per mile, or about 2 cents.

sns.regplot(x="Owner_Count", y="Mileage", data=data, scatter=True, line_kws={"color": "red"})  
print(np.polyfit(x=data.Owner_Count,y=data.Mileage, deg=1))
plt.show()

#This calculation and chart shows that each owner will add, on average 148098 miles to their car before selling it. 