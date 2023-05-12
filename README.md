# Banker-algorithm 
This program is used to implement the banker's algorithm for deadlock prevention. 

## GUI inputs

In the GUI, there are 4 input grid tables: 

1. Total resources 
2. Available resources 
3. Current allocation 
4. Maximum need 

There's also a button called "Calculate" where the banker's algorithm is executed.

## Resource request

The second part of the algorithm allows the user to enter that a particular process requests a certain number of a particular resource. The program should then use the banker's algorithm to determine whether or not to grant the request. 

There are three text boxes in the GUI: 

1. Process index 
2. Resource index 
3. Request amount 

There's also a button called "Request" where the second code is put.

## Algorithm description

This algorithm is used to check if a system is in a safe state or not. The method first reads input values from grid views and then runs the banker's algorithm. The while loop runs until all the processes have been executed or it is found that the system is in an unsafe state. 

The algorithm checks if a process can be executed. If yes, then it executes the process and adds it to the safe sequence. The algorithm also maintains a finish array to keep track of the processes that have been executed.

Finally, the method shows a message box with either a message that the system is in a safe state along with the safe sequence of processes or a message that the system is not in a safe state.

## Simulating resource request

The purpose of this method is to simulate a request for resources made by a process in the system. When the button is clicked, the method first reads in the current state of the system from the UI grid views. It then checks if the requested amount of resources is a valid request based on the current state of the system.

If the request is valid, the method simulates the allocation of resources to the requesting process by updating the current allocation, need, and available resources arrays. After the simulated allocation, the method checks if the new state of the system is safe by running the banker's algorithm, just like in the first event handler. If the new state is safe, the method displays a message box indicating that the request was granted and the system is in a safe state. Otherwise, it displays a message box indicating that the request was denied and the system is not in a safe state.
