user.fullname;



class Student {
    fullname : string;
    p : Person;
    constructor(public firstname, public middleinitial, public lastname) {
        this.fullname = firstname + " " + middleinitial + " " + lastname;
    },
    function foo() {
    }
}

interface Person {
    firstname: string;
    lastname: string;
}

function greeter(person : Person) {
    return "Hello, " + person.firstname + " " + person.lastname;
}

var user = new Student("Jane", "M.", "User");
