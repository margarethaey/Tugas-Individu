//Inisialisasi, Pembuatan Element, Aksi, dan Metode
var x = document.getElementById("form");
var createform = document.createElement('form');
createform.setAttribute("action", "");
createform.setAttribute("method", "post");
x.appendChild(createform);
 
//Tambahkan Heading & Heading Line Untuk Title
var heading = document.createElement('h2');
heading.innerHTML = "Kontak Kami";
createform.appendChild(heading);
var line = document.createElement('hr');
createform.appendChild(line);
 
//Beri Jarak Setelah Heading Line
var linebreak = document.createElement('br');
createform.appendChild(linebreak);
 
//Tambahkan Label Untuk Form
var namelabel = document.createElement('label');
namelabel.innerHTML = "Nama kamu : ";
createform.appendChild(namelabel);
 
//Tambah Kolom Input Untuk Form
var inputelement = document.createElement('input');
inputelement.setAttribute("type", "text");
inputelement.setAttribute("name", "dname");
createform.appendChild(inputelement);
 
//Beri Jarak Setelah Input
var linebreak = document.createElement('br');
createform.appendChild(linebreak);
 
//Tambahkan Label Untuk Form
var emaillabel = document.createElement('label');
emaillabel.innerHTML = "Email kamu : ";
createform.appendChild(emaillabel);
 
//Tambahkan Kolom Input Untuk Form
var emailelement = document.createElement('input');
emailelement.setAttribute("type", "text");
emailelement.setAttribute("name", "demail");
createform.appendChild(emailelement);
 
//Beri Jarak Setelah Input
var emailbreak = document.createElement('br');
createform.appendChild(emailbreak);
 
//Tambahkan Label Untuk Form
var messagelabel = document.createElement('label');
messagelabel.innerHTML = "Pesan kamu : ";
createform.appendChild(messagelabel);
 
//Tambahkan Kolom Input Untuk Form
var texareaelement = document.createElement('textarea');
texareaelement.setAttribute("name", "dmessage");
createform.appendChild(texareaelement);
 
//Beri Jarak Setelah Input
var messagebreak = document.createElement('br');
createform.appendChild(messagebreak);
 
//Tambahkan Button Submit Untuk Pengiriman Data
var submitelement = document.createElement('input');
submitelement.setAttribute("type", "submit");
submitelement.setAttribute("name", "dsubmit");
submitelement.setAttribute("value", "Submit");
createform.appendChild(submitelement);