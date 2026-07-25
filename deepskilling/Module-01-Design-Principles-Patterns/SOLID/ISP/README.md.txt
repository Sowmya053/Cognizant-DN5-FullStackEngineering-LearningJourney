# Interface Segregation Principle (ISP)

A class should not be forced to implement methods it does not need.

Interfaces Used:

1. IWork
2. IEat

Human implements both IWork and IEat.

Robot implements only IWork.

Output:
Human is working
Human is eating
Robot is working