# Nonlinear-BisectionMethod
solving a nonlinear problem with bisection method

BISECTION METHOD

The bisection method in mathematics is a root-finding method that repeatedly bisects an interval and then selects a subinterval in which 
a root must lie for further processing. It is a very simple and robust method, but it is also relatively slow. Because of this, it is 
often used to obtain a rough approximation to a solution which is then used as a starting point for more rapidly converging methods. 
The method is also called the interval halving method, the binary search method, or the dichotomy method.

The input for the method is a continuous function f, an interval [a, b], and the function values f(a) and f(b). The function values are 
of opposite sign (there is at least one zero crossing within the interval). Each iteration performs these steps:

1-) Calculate c, the midpoint of the interval, c = (a + b)/2.

2-) Calculate the function value at the midpoint, f(c).

3-) If convergence is satisfactory (that is, c - a is sufficiently small, or |f(c)| is sufficiently small), return c and stop iterating.

4-) Examine the sign of f(c) and replace either (a, f(a)) or (b, f(b)) with (c, f(c)) so that there is a zero crossing within the new 
interval.
