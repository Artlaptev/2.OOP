using Task1;

Rational rational1 = new Rational("25/3");
Rational rational2 = new Rational("5/2");
Rational rational3 = new Rational("1/5");
Rational rational4 = new Rational("2/5");
Rational rational5 = new Rational("6/3");

Rational result = rational1 + rational2;
result = rational2 * rational3;
result = rational3 / rational4;
result = rational4 % rational5;
result = rational5++;
Console.ReadKey();