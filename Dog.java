class Dog extends Animal {
  
  int age;

	public Dog(int dogsAge) {
    
  	age = dogsAge;
    
  }
  
  public void bark() {
		
    System.out.println("Woof!");
    
	}
	
  public void run(int yards) {
    
    System.out.println("Your dog ran " + yards + " yards!");

	}
  
  public int getAge() {

    return age;
    
	}
  
	public static void main(String[] args) {
    
    Dog spike = new Dog(1);
    spike.bark();
    spike.run(20);
    spike.checkStatus();
    int spikeAge = spike.getAge();
    System.out.println(spikeAge);

	}

}
