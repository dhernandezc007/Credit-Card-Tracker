Credit Card Tracker (Zorro's Debt Manager)
This C# Windows Forms application is designed to help Zorro manage his various credit cards. 
It allows for reading card data from files, tracking interest, adding new debt, and managing current balances through an interactive interface.

Features
The application provides a comprehensive suite of tools for debt management:
1. Data Management
File Import: Automatically reads card names, amounts owed, and interest rates from a comma-separated data file.
Persistent Storage: Upon exiting, the program saves all current data back to the file, ensuring information is preserved for the next session.
Object-Oriented Design: Uses a custom CreditCard class to handle data encapsulation and interest calculations.

2. Interactive Interface
Sorted Overview: Displays all credit cards in a list box, automatically sorted alphabetically for easy navigation.
Real-time Updates: Selecting a card instantly displays the card name, amount owed, interest rate, and the specific dollar interest owed.
Transaction Handling: By double-clicking a card, you can add or subtract funds. The program prompts you with the current balance and updates the labels and list box immediately.

3. Card Operations
Add New Cards: Use the More Debt button to add new lines of credit. The system includes validation to prevent duplicate card names (case-insensitive).
Remove Cards: The Cut It Up button allows for card deletion with a safety confirmation prompt (Yes/No) to prevent accidental data loss.

Interest Calculation FormulaThe interest displayed in the labels is calculated as follows:
Interest Owed = Amount Owed X Interest
