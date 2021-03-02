// incomeList[]: the array recording the individual income items

// childList[]: the array recording the ages of children supported by this person

// parentList[]: the array recording the ages of parents supported by this person

 

public double computeTax(double[] incomeList, int[] parentList, int[] childList) {
double taxAmount = 0.0;
double incomeAmount = 0.0;
 

// calculate the income amount

for (int i = 0; i < incomeList.length; i++) {
incomeAmount = incomeAmount + incomeList[i]; 6  }
 

// calculate the basic tax

if (incomeAmount <= 40000) {
taxAmount = incomeAmount * 0.02;
} else if (incomeAmount > 40000 && incomeAmount <= 80000) {
taxAmount = 800 + incomeAmount * 0.07;
} else if (incomeAmount > 80000 && incomeAmount <= 120000) {
taxAmount = 800 + 2800 + incomeAmount * 0.12;
} else if (incomeAmount > 120000) {
taxAmount = 800 + 2800 + 4800 + incomeAmount * 0.17; 15 }
 

// calculate the tax exemption from having children

int taxExemption = 0;
int numOfChild = childList.length;
while (numOfChild > 0) {
if (childList[numOfChild - 1] < 18) {
taxAmount = taxAmount - 4000;
taxExemption = taxExemption + 4000; 22      }
23 numOfChild--; 24 }


// calculate the tax exemption from having parents

for (int j = 0; j < parentList.length; j++) {
if (parentList[j] > 60) {
taxAmount = taxAmount - 2000;
taxExemption = taxExemption + 2000; 29      }
30 }

 

// the maximum tax exemption is 8000 each person

if (taxExemption <= 8000) {
if (taxAmount >= 0) {
return taxAmount;
} else { // i.e., taxAmount <0
return 0; 36 }
} else { // i.e., taxExemption > 8000
taxAmount = taxAmount + (taxExemption - 8000);
return taxAmount;
}
}