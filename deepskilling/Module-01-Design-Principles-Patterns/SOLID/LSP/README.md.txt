# Liskov Substitution Principle (LSP)

A derived class should be substitutable for its base class without affecting program correctness.

In this example:

- Sparrow can fly.
- Penguin cannot fly.

Instead of forcing Penguin to implement Fly(), we separate flying behavior into IFlyable.

Output:
Sparrow is flying
Penguin is swimming