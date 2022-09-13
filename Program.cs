string output = "Placeholder";


#region Test Calculations


void CreatePoint(){
    // Create a new vertex point that defaults to 0,0,0
    var emptyVertex = new int[][] {
        new int[]{0,0,0},
        new int[]{0,0,0},
        new int[]{1,1,1}
    };
    return emptyVertex;
}

#endregion

Console.WriteLine("Hello, World!");
var test = CreatePoint();

Console.WriteLine(output);