  
  
class Student {
    fullname : string;
    p : Person;
    constructor(public firstname, public middleinitial, public lastname) {
        this.fullname = firstname + " " + middleinitial + " " + lastname;
    }
}

interface Person {
    firstname: string;
    lastname: string;
    foo(s: string): string;
}

function greeter(person : Person) {
    return "Hello, " + person.firstname + " " + person.lastname + person.foo();
}

var user = new Student("Jane", "M.", "User").;