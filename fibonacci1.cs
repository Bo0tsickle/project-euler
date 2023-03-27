using System;

int fib1 = 1;
int fib2 = 2;
int sum = 2;

for (int i = 0; i < 4_000_000; i++) {
    if ((fib1 + fib2 == i) && (i % 2 == 0)) {
        sum += i;
    }
}

return sum;