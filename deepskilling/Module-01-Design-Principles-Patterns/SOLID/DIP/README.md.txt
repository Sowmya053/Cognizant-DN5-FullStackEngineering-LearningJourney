# Dependency Inversion Principle (DIP)

High-level modules should not depend on low-level modules.

Interface:
- IMessage

Implementations:
- Email
- SMS

Notification depends on IMessage instead of Email or SMS directly.

Output:
Email Sent