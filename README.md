# Spring 2025 Assignment 02 - Control Structures and Error Handling
__Weight:__ 10% of final mark

__Submission requirements:__ On or before the deadline, commit a .NET 8 Visual Studio 2022 project to the GitHub repository. __You must commit and push to the classroom repository supplied for the assignment__; do not create your own repository. It is your responsibility to ensure that your work is in the correct repository. ___Work not in the repository will not be graded___.

## Donair Order Calculator
Your friend is opening a late-night donair counter and needs your help developing a program to calculate the total price of customer orders.

Each customer can place an order for multiple copies of the same kind of donair — that means they choose one configuration (size and extras), and then indicate how many of that donair they want.


### Requirements
The program will need to prompt the user for:

- the donair **size**: Regular, Large, or Super
- whether the donair should include **extra cheese**, **extra meat**, or **both**
- the **quantity** of donairs (as a whole number)

The base prices for donairs are:

| Size    | Price per donair |
| ------- | ---------------- |
| Regular | 6.50             |
| Large   | 8.00             |
| Super   | 9.50             |

Each donair can include optional extras, charged per donair:

| Add-on       | Additional cost |
| ------------ | --------------- |
| Extra Cheese | 1.25            |
| Extra Meat   | 2.00            |

A discount of 10% off the subtotal is applied if the order total (before tax) exceeds $40.00.

GST is charged at 5% of the subtotal (after any discount).

For example, let’s say a customer orders 5 large donairs with both extra cheese and extra meat:

- Base donair cost: 5 × $8.00 = $40.00
- Add-ons: 5 × ($1.25 + $2.00) = $16.25
- Subtotal: $40.00 + $16.25 = $56.25
- Discount (10%): $5.63
- Discounted subtotal: $56.25 − $5.63 = $50.62
- GST: 5% of $50.62 = $2.53
- Total cost: $50.62 + $2.53 = $53.15

The program must display the subtotal, discount, GST, and total aligned by decimal place, then ask the user if they’d like to place another order. The program must continue looping until the user chooses to quit.

The program must not crash due to invalid user input or internal errors. Use appropriate error messages and recover from invalid input gracefully.

## Coding Requirements
- A C# comment block at the beginning of the source file describing the purpose, author, and last modified date of the program
- Use defensive programming where necessary
- Ensure graceful handling of exceptions

### Sample Runs
_NOTE: the full functionality and logic of this program is not demonstrated in the samples below.  **You will need to develop your own test plan and sample runs for the full program.**_
The following GIF demonstrates the functionality of the program for 2 sets of inputs:
![assign1](images/sample.gif)


## Submission
Commit and push your solution to your GitHub classroom assignment repository before the deadline. Ensure that your solution follows the best coding and style practices, as your instructor has shown you in class. Failed adherence to the prescribed style guidelines may result in lost marks. __Your program must compile; a program that fails to compile will not be graded.__

_NOTE: push early and often to your repository to receive feedback from your instructor prior to the deadline. Your instructor will not be providing feedback for every commit every day. However, the earlier and more often you commit, the greater the chances of your instructor reviewing your work and providing constructive feedback that you can act on before the deadline._

## Rubric (out of 15 marks)

| Criteria |  Good (3 marks) | Acceptable (2 marks) | Needs Work (1 mark) | Unsatisfactory (0 marks)
|-|-|-|-|-|
| Structure | Program prompts for all required inputs, appropriate data types are used, and program loops until user quits. | 1-2 minor errors in data types or loop logic. | Missing inputs, missing loop, or major logic errors. | Not completed.
| Calculations | Base cost, add-ons, discount, GST, & total cost are correctly calculated.	 | 1-2 minor errors in calculation. | Major errors or missing parts of calculation. | Calculations not attempted.
| Exception Handling | Program does not crash for any reason. | Program crashes on invalid input in some cases. | Program crashes on invalid input in most/all cases. | Program does not run / was not completed.
| Correctness | All tests pass. | Most tests pass. | Some tests pass. | No tests pass.
| Best practices | Code follows course best practices including good naming conventions, properly aligned output, opening comment block, and appropriate use of comments. | 1-2 minor errors or violations. | 3+ errors or standard violations. | No alignment, documentation, or appropriate names.

