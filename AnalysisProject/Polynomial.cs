using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalysisProject
{
    class PolynomialPart
    {
        public PolynomialPart next;
        public PolynomialPart previous;
        public double a;
        public int n;

        public PolynomialPart(double a,int n)
        {
            next = previous = null;
            this.a = a;
            this.n = n;
        }
        
    }
    class Polynomial
    {
        private PolynomialPart Head;

        public Polynomial()
        {
            Head = null;            
        }

        public Polynomial(Polynomial P)
        {
            Head = null;
            PolynomialPart temp=P.Head;
            while(temp!=null)
            {
                this.Add(temp.a, temp.n);
                temp = temp.next;
            }
        }
        public void Add(double a, int n)
        {
            if (a == 0)
                return;

            if (Head == null)
                Head = new PolynomialPart(a, n);
            else if(n>Head.n)
            {
                Head.previous = new PolynomialPart(a, n);
                Head.previous.next = Head;
                Head = Head.previous;                
            }
            else if (n == Head.n)
            {
                Head.a += a;
                if (Head.a == 0)
                {
                    Head = Head.next;
                    if(Head!=null)
                        Head.previous = null;
                }
            }
            else
            {
                PolynomialPart temp = Head;
                while (temp.next != null && n < temp.next.n)
                    temp = temp.next;

                if (temp.next == null)
                {
                    temp.next = new PolynomialPart(a, n);
                    temp.next.previous = temp;
                    return;
                }
                else if (n == temp.next.n)
                {
                    temp.next.a += a;
                    if (temp.next.a == 0)
                    {
                        PolynomialPart t=temp.next;
                        temp.next = t.next;
                        if(t.next!=null)
                            t.next.previous = temp;                                                
                    }
                }
                else
                {
                    PolynomialPart node = new PolynomialPart(a, n);
                    node.next = temp.next;
                    node.previous = temp;
                    node.previous.next = node;
                    node.next.previous = node;
                }
            }
        }

        public double value(double x)
        {
            PolynomialPart temp=Head;
            double d=0;
            while (temp != null)
            {
                d += (temp.a) * System.Math.Pow(x, (double)temp.n);
                temp = temp.next;
            }
            return d;
        }

        public static Polynomial operator +(Polynomial P1, Polynomial P2)
        {
            Polynomial P3 = new Polynomial();

            PolynomialPart t1 = P1.Head, t2 = P2.Head; ;

            while (t1 != null)
            {
                P3.Add(t1.a, t1.n);
                t1 = t1.next;
            }

            while (t2 != null)
            {
                P3.Add(t2.a, t2.n);
                t2 = t2.next;
            }

            return P3;
        }
        public static Polynomial operator +(double x, Polynomial P1)
        {
            Polynomial P2 = new Polynomial();
            P2.Add(x, 0);

            return P1 + P2;
        }

        public static Polynomial operator +(Polynomial P1, double x)
        {
            return x + P1;
        }

        public static Polynomial operator -(Polynomial P1, Polynomial P2)
        {
            Polynomial P3 = P2*(-1);
            return P1 + P3;
        }

        public static Polynomial operator -(double x, Polynomial P1)
        {
            Polynomial P2 = new Polynomial();
            P2.Add(x, 0);

            return P1 - P2;
        }

        public static Polynomial operator -(Polynomial P1, double x)
        {
            return (-x) + P1;
        }

        public static Polynomial operator *(double x, Polynomial P1)
        {
            Polynomial P2 = new Polynomial();
            P2.Add(x, 0);

            return P1 * P2;
        }

        public static Polynomial operator *(Polynomial P1, double x)
        {
            return x * P1;
        }                
 
        public static Polynomial operator *(Polynomial P1, Polynomial P2)
        {
            Polynomial P3 = new Polynomial();

            PolynomialPart t1 = P1.Head, t2;

            while (t1 != null)
            {
                t2 = P2.Head;
                while (t2 != null)
                {
                    P3.Add(t1.a * t2.a, t1.n + t2.n);
                    t2 = t2.next;
                }
                t1 = t1.next;
            }

            return P3;
        }
        
        override public string ToString()
        {
            if (Head == null)
                return "0";
            
            string s="";
            PolynomialPart temp = Head;
            while (temp != null)
            {
                s += temp.a.ToString() + "*x^" + temp.n.ToString() + " +";
                temp = temp.next;
            }           

            string s2="";

            for (int i = 0; i < s.Length-1;)
            {
                if (s[i] == '+' && s[i + 1] == '-')
                {
                    s2 += s[i + 1];
                    i += 2;
                }
                else if(s[i] == '1' && s[i+1]=='*' && s[i+2]=='x' && s[i+4]=='0')
                {
                    s2 += "1";
                    i += 5;
                }
                else if (s[i] == '^' && s[i + 1] == '1' && s[i+2] ==' ')
                    i += 2;
                else if (s[i] == '*' && s[i + 3] == '0')
                    i += 4;
                else if (s[i] == '1' && s[i + 1] == '*' && (i==0 || s[i-1]==' '))
                    i += 2;
                else if (s[i] == '^' && s[i + 1] == '-')
                {
                    s2 += s[i];
                    s2 += "(-";
                    i += 2; ;
                    while (s[i] > '0' && s[i] < '9')
                    {
                        s2 += s[i];
                        i++;
                    }
                    s2 += ')';
                }
                else
                {
                    s2 += s[i];
                    i++;
                }


                
            }

            return s2;
        }
    }
}
