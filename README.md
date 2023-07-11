# Lab2-ATM

## Lab2 ATM Application

This is a simple ATM (Automated Teller Machine) application implemented in C#. It provides basic functionalities like viewing balance, withdrawing money, and depositing money. The application has a user interface that allows users to interact with the ATM and perform various operations on their account.

### Visuals

Here's an example of how the ATM application looks in action:

```
Welcome!
Press 1 to see your Balance
Press 2 to Withdraw money
Press 3 to Deposit money
```

### How to Use

To use the ATM application, follow these steps:

1. Run the application.
2. You will be greeted with a welcome message.
3. Choose from the available options:
   - Press 1 to view your balance.
   - Press 2 to withdraw money.
   - Press 3 to deposit money.
4. If you choose option 1, your current balance will be displayed.
5. If you choose option 2, you will be prompted to enter the amount you want to withdraw. After entering the amount, your balance will be updated accordingly.
6. If you choose option 3, you will be prompted to enter the amount you want to deposit. After entering the amount, your balance will be updated accordingly.
7. If you enter an invalid option, you will be asked to enter a valid option.
8. The menu will be displayed again after each operation, allowing you to perform additional actions or exit the program.

### Additional Details

- The initial balance is set to $100.05 for demonstration purposes. You can modify it in the code if needed.
- The application uses the `decimal` data type to handle monetary values accurately.
- The user interface provides a loop that allows the user to perform multiple operations until they choose to exit.
- The application includes test methods (`ViewBalanceTest`, `DepositTest`, `WithdrawTest`) that can be used to test the functionality of the main methods (`ViewBalance`, `Deposit`, `Withdraw`). The tests validate the expected behavior of the methods by comparing the calculated balances with the expected results.

Please note that this is a basic implementation of an ATM application and does not include advanced features such as user authentication or transaction history. It serves as a starting point for building more sophisticated ATM systems.