// See https://aka.ms/new-console-template for more information
Console.WriteLine(
    "1 - fill_up_b5, 2 - fill_up_b3, 3 - pour_out_b5," + 
    " 4 - pour_out_b3, 5 -  from_b5_to_b3, 6 - from_b3_to_b5 "
    );
int b5 = 0;
int b3 = 0;
int status;
int sum;

while (b5 != 4){
    Console.WriteLine("b5 = {0}, b3 = {1} ", b5, b3);
    status = Convert.ToInt32(Console.ReadLine());
    switch (status){
        case 1: // fill_up_b5
            b5 += 5;
            if (b5 > 5){
                b5 = 5;
            } continue;
        case 2: // fill_up_b3
            b3 += 3;
            if (b3 > 3){
                b3 = 3;
            } continue;
        case 3: // pour_out_b5
            b5 -= 5;
            if (b5 < 5){
                b5 = 0;
            } continue;
        case 4: // pour_out_b3
            b3 -= 3;
            if (b3 < 3){
                b3 = 0;
            } continue;
        case 5: // from_b5_to_b3
            sum = b5 + b3;
            b5 = sum - 3;
            if (b5 < 0){
                b5 = 0;
            } b3 = sum - b5;
            if (b3 < 0){
                b3 = 0;
            } continue;
        case 6: // from_b3_to_b5
            sum = b3 + b5;
            b3 = sum - 5;
            if (b3 < 0){
                b3 = 0;
            } b5 = sum - b3;
            if (b5 < 0){
                b5 = 0;
            } continue;
    }
}
Console.WriteLine("b5 = {0}, b3 = {1} ", b5, b3);
Console.WriteLine("You win!");
Console.ReadKey();
