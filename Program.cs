using Chapter010;

Solution4 Solution4 = new Solution4();

object[] array = new object[]
{
    1,
    2,
    3,
    new object[] { 4, 5, 6 },
    7,
    new object[] {
        8,
        new object[] {
            9, 10, 11,
            new object[] { 12, 13, 14 }
        }
    },
    new object[] {
        15, 16, 17, 18, 19,
        new object[] {
            20, 21, 22,
            new object[] {
                23, 24, 25,
                new object[] { 26, 27, 29 }
            },
            30, 31
        },
        32
    },
    33
};

Solution4.printArrayRecursively(array);
