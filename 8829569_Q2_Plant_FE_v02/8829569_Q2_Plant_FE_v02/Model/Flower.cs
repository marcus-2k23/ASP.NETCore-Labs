// Name: 
// Section: 1
// Version: Final
// Student Number: 8829569


// Create a Flower class that inherits from the Plant class.

public class Flower : Plant{
    public int height;

// Add a property called Height. Make it the appropriate variable type.
    public Flower(){
        try{
            this.plantType = "Flower";
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
        
    }
}