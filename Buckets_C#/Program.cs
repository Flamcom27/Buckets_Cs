// See https://aka.ms/new-console-template for more information
Console.WriteLine(
    "1 - fill_up_b5, 2 - fill_up_b3, 3 - pour_out_b5," + 
    " 4 - pour_out_b3, 5 -  from_b5_to_b3, 6 - from_b3_to_b5 "
    );
int b5 = 0;
int b3 = 0;
while (b5 != 4){
    Console.WriteLine("b5 = " + Convert.ToString(b5) + " b3 = " + Convert.ToString(b3));
    int status = Convert.ToInt32(Console.ReadLine());

    if (status == 1){ // fill_up_b5
        b5 += 5;
        if (b5 > 5){
            b5 = 5;
        }
    }
    else if(status == 2){ // fill_up_b3
        b3 += 3;
        if (b3 > 3){
            b3 = 3;
        } 

    }
    else if(status == 3){  // pour_out_b5
        b5 -= 5;
        if (b5 < 5){
            b5 = 0;
        }

    }
    else if(status == 4){ // pour_out_b3
        b3 -= 3;
        if (b3 < 3){
            b3 = 0;
        } 

    }
    else if(status == 5){ // from_b5_to_b3
        int sum = b5 + b3;
        b5 = sum - 3;
        if (b5 < 0){
            b5 = 0;
        }
        b3 = sum - b5;
            if (b3 < 0){
            b3 = 0;
        }

    }
    else if(status == 6){ // from_b3_to_b5
        int sum = b3 + b5;
        b3 = sum - 5;
        if (b3 < 0){
            b3 = 0;
        }
        b5 = sum - b3;
            if (b5 < 0){
            b5 = 0;
        }

    }


} 

Console.WriteLine("b5 = " + Convert.ToString(b5) + " b3 = " + Convert.ToString(b3));
Console.WriteLine("You win!");
Console.ReadKey();

