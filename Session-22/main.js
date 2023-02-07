 //exe1
 
function reverse(){
    let str = document.getElementById("reverse").value;
    let result = reverseString(str);
    document.getElementById("result").value = result;
    
    if(str==reverseString(str)){
        document.getElementById('palindrome').innerHTML = "It's a palindrome";
    }else{
        var x = document.getElementById('palindrome');
        x.innerHTML = "It's not a palindrome";
    }
}

function reverseString(str) {
    let splitString = str.split("");
 
    let reverseArray = splitString.reverse(); 
 
    let joinArray = reverseArray.join(""); 
    return joinArray; 
}

//exe5
function newString(){
    let str = document.getElementById("firstString").value;
    let splited=str.split("");
    let y=splited[splited.length-1];
    var newstring;
    if(isNaN(y)){
        document.getElementById("secondString").value = str+1;
    
    }else{
     let last = parseInt(splited[splited.length-1])+1;
     newstring = str.slice(0, -1) + last;
     document.getElementById("secondString").value = newstring;
   
    }
}
//Exe 3
var customers = [];
function addCustomer(){
    const table = document.getElementById("tblCustomers");
    let fname = document.getElementById('fname').value;
    let lname = document.getElementById('lname').value;
    let custage = document.getElementById('age').value;

const newCustomer ={
    name : fname,
    lastname : lname,
    age : custage
};
    customers.push(newCustomer);
    createCustomersTableRow(newCustomer, table);
    
}
function createCustomersTableRow(customer, tableEl) {
    let rowEl = tableEl.insertRow();

    let nameEl = rowEl.insertCell(0);
    nameEl.innerHTML = customer.name;

    let surnameEl = rowEl.insertCell(1);
    surnameEl.innerHTML = customer.lastname;

    let ageEl = rowEl.insertCell(2);
    ageEl.innerHTML = customer.age;
}


//exe4 we need to check if a and b are numbers
let a=13;
let b='3.1e';
mult(a,b);
function mult(a,b){
    if(!isNaN(a) && !isNaN(b)){
        console.log(a*b);
    }else{
        console.error("a or b are not numbers");
    }
}
