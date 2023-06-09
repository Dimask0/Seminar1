Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(count<2*N+1){
if(count<N){
    Console.Write($"{-N + count}");
}
else if (count == N){
    Console.Write("0");
}
else {
    Console.Write($"{count - N}");
}
count++;
}
