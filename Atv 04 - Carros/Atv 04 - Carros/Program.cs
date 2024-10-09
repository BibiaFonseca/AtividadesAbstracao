using Atv_04___Carros;

Carros carro1 = new Carros("Nissan", "Skyline GTR R34", "250 km/h 156 MPH");
Console.WriteLine("A marca do carro é:" + carro1.Marca + "\nO modelo do carro é: " + carro1.Modelo + "\nA velocidade máxima do carro é: " + carro1.Velocidade);
carro1.Acelerar();
carro1.Desacelerar();

Carros carro2 = new Carros("Porshe", "911 GT3 RS", "296 km/h");
Console.WriteLine("\nA marca do carro é:" + carro2.Marca + "\nO modelo do carro é: " + carro2.Modelo + "\nA velocidade máxima do carro é: " + carro2.Velocidade);
carro2.Acelerar();
carro2.Desacelerar();

Carros carro3 = new Carros("McLaren", "P1", "364 km/h 222mph");
Console.WriteLine("\nA marca do carro é:" + carro3.Marca + "\nO modelo do carro é: " + carro3.Modelo + "\nA velocidade máxima do carro é: " + carro3.Velocidade);
carro3.Acelerar();
carro3.Desacelerar();