let students = [
    {
        id: 1,
        name: "Nurane",
        surname: "IsmayilzNamee",
        age: 21,
        hobbies: ["music", "walking", "watchingfilm"],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "cavid" },
            { id: 4, name: "alisa" },
        ],
        loginDetail: { username: "nurana21", password: "nunu123" },
        gender: "girl",
        boyfriendGirlfriend: false,
        fail: false,
        avgPoint: 88,
        salaryAZN: 144,
    },
    {
        id: 2,
        name: "Gizilgul",
        surname: "Allahverdiyeva",
        age: 20,
        hobbies: ["book", "writing code"],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "babaxan" },
            { id: 4, name: "gulshen" },
        ],
        loginDetail: { username: "allahverdieva1", password: "salam123" },
        gender: "girl",
        boyfriendGirlfriend: true,
        fail: false,
        avgPoint: 70,
        salaryAZN: 100,
    },
    {
        id: 3,
        name: "Xanim",
        surname: "Nuriyeva",
        age: 21,
        hobbies: ["book", "music"],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "hikmet" },
            { id: 4, name: "gulsen" },
        ],
        loginDetail: { username: "xanim123", password: "salamBaku" },
        gender: "girl",
        boyfriendGirlfriend: false,
        fail: false,
        avgPoint: 80,
        salaryAZN: 145,
    },
    {
        id: 4,
        name: "Minaya",
        surname: "Binnetova",
        age: 21,
        hobbies: ["book", "gaming", "movie", "music"],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "anar" },
        ],
        loginDetail: { username: "binnetova", password: "hello123" },
        gender: "girl",
        boyfriendGirlfriend: false,
        fail: false,
        avgPoint: 90,
        salaryAZN: 142,
    },
    {
        id: 5,
        name: "Sabina",
        surname: "Hatamli",
        age: 21,
        hobbies: ["shopping", "listen to music"],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "Mirvari" },
        ],
        loginDetail: { username: "sebine123", password: "salam123" },
        gender: "girl",
        boyfriendGirlfriend: true,
        fail: false,
        avgPoint: 81,
        salaryAZN: 146,
    },

    {
        id: 6,
        name: "Ləman",
        surname: "Şamilova",
        age: 20,
        hobbies: [
            "watching movies",
            "reNameing books",
            "painting",
            " walking",
            " listen to music",
        ],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
        ],
        loginDetail: { username: "lemanshamilova", password: "salamBaku" },
        gender: "girl",
        boyfriendGirlfriend: false,
        fail: false,
        avgPoint: 85.8,
        salaryAZN: 145,
    },
    {
        id: 7,
        name: "Narmin",
        surname: "Musayeva",
        age: 21,
        hobbies: ["book", "gaming", "painting", "walking"],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "fidan" },
            { id: 4, name: "IrNamea" },
        ],
        loginDetail: {
            username: "narmin0",
            password: "narmin01",
        },
        gender: "girl",
        boyfriendGirlfriend: false,
        fail: false,
        avgPoint: 80,
        salaryAZN: 196,
    },

    {
        id: 8,
        name: "Fatima",
        surname: "AkhundzNamea",
        age: 20,
        hobbies: ["drawing", "sleeping"],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "Valida" },
        ],
        loginDetail: { username: "aynur123", password: "salamBaku" },
        gender: "girl",
        boyfriendGirlfriend: true,
        fail: false,
        avgPoint: 76,
        salaryAZN: 100,
    },
    {
        id: 9,
        name: "Elmir",
        surname: "Huseynov",
        age: 21,
        hobbies: ["book", "ice skating", "Tennis", "Karting"],
        student: true,
        teacher: [
            { id: 1, name: "Gurban" },
            { id: 2, name: "Hajar" },
            { id: 3, name: "MorName" },
            { id: 4, name: "Fikrat" },
        ],
        loginDetail: { username: "huseynovelmirr", password: "maxverstappen" },
        gender: "man",
        boyfriendGirlfriend: false,
        fail: true,
        avgPoint: 76,
        salaryAZN: 120,
    },
    {
        id: 10,
        name: "Fidan",
        surname: "Rehimli",
        age: 21,
        hobbies: ["book", "gaming"],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "Turan" },
        ],
        loginDetail: { username: "fidan123", password: "fidanrahimli" },
        gender: "girl",
        boyfriendGirlfriend: true,
        fail: true,
        avgPoint: 75,
        salaryAZN: 98,
    },
    {
        id: 11,
        name: "Aynur",
        surname: "Aynurova",
        age: 20,
        hobbies: ["book", "gaming"],
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
        ],
        loginDetail: { username: "aynur123", password: "salamBaku" },
        gender: "girl",
        boyfriendGirlfriend: true,
        fail: true,
        avgPoint: 81,
        salaryAZN: 120,
    },

    {
        id: 12,
        name: "Elman",
        surname: "MurNameov",
        age: 20,
        hobbies: [
            "book",
            "gaming",
            "sking",
            "wrestling",
            "swiming",
            "arguing about philosophy",
            "solving sudoku",
            "hiking",
            "walking",
        ],
        student: true,
        teacher: [
            { id: 1, name: "gurban" },
            { id: 2, name: "hajar" },
            { id: 3, name: "jale" },
            { id: 4, name: "akhmed" },
        ],
        loginDetail: { username: "elman17", password: "elman12345" },
        gender: "girl",
        boyfriendGirlfriend: false,
        fail: true,
        avgPoint: 76,
        salaryAZN: 100,
    },
];



students.forEach(student => {
    console.log(student)
});


students.forEach(student => {
    console.log(`Name:${student.name}`)
});


students.forEach(student => {
    console.log(`Name:${student.name} Surname:${student.surname}`)
});


for (let student of students) {
    if (student.fail) {
        console.log(`Name:${student.name} Surname:${student.surname} Failed`)

    }
}


let maxHobbiesStudent = students[0];

for (let student of students) {

    if (student.hobbies.length > maxHobbiesStudent.hobbies.length) {
        maxHobbiesStudent = student
    }
}

console.log(maxHobbiesStudent);




let maxAvgPointStudent = students[0];

for (let student of students) {

    if (student.avgPoint > maxHobbiesStudent.avgPoint) {
        maxAvgPointStudent = student
    }
}
console.log(` max avgpoint:${maxAvgPointStudent.avgPoint}  Name:${maxAvgPointStudent.name} Surname:${maxAvgPointStudent.surname} `)



let longestPasswordStudent = students[0];

for (let student of students) {

    if (student.loginDetail.password.length > longestPasswordStudent.loginDetail.password.length) {
        maxAvgPointStudent = student
    }
}
console.log(`Name:${longestPasswordStudent.name} Surname:${longestPasswordStudent.surname} `)

// - boyfriend-i olan tələbələrin adlarını və username-lərini çapa verin

for (let student of students) {
    if (student.boyfriendGirlfriend) {
        console.log(`UserName:${student.loginDetail.username}`)
    }
}


// - yaşı 20 olan tələbələrin adlarını və müəllim adlarını çapa verin

for (let student of students) {
    if (student.age == 20) {
        let names = "";
        for (let teacher of student.teacher) {
            names += " " + teacher.name
        }
        console.log(`Teacher Name:${names}`)
    }
}


students.forEach(student => {
    student.salaryAZN = "$" + student.salaryAZN
    console.log(student)
});


// - Müəllimlərin baş hərflərini böyük hərflə yazın



for (let student of students) {

    let names = "";
    for (let teacher of student.teacher) {
        names += " " + teacher.name[0].toUpperCase() + teacher.name.substring(1)
    }
    console.log(`Teacher Name:${names}`)

}


// - Şifrəsində rəqəm olmayan tələbələri tapın


var hasNumber = /\d/;


for (let student of students) {
    if (!hasNumber.test(student.loginDetail.password)) {
        console.log(student)
    }
}

// - Qızların arasında id-si 3 olan müəllimlərin adını deyin

for (let student of students) {


    for (let teacher of student.teacher) {
        if (teacher.id == 3) {
            console.log(`Teacher Name:${teacher.name}`)
        }
    }


}

// - Tələbələrin adlarını və müəllim saylarını çapa verin

students.forEach(student => {
    console.log(`Name:${student.name} Teacher count:${student.teacher.length}`)

});


// - Tələbələrin adlarını username və şifrələrindən ibarət yeni array yaradın [{name:qurban,username:qurban123,password:qqq123}]

let newArray = [];

students.forEach(student => {
    newArray.push({
        name: student.name,
        username: student.loginDetail.username,
        password: student.loginDetail.password
    })

});

newArray.forEach(student => {
    console.log(student)
});

// - Müəllimlərin adlarından sonra müəllim sözünü əlavə edin. String metod istifadə edin

students.forEach(student => {
    student.teacher.forEach(teacher=>{
        teacher.name="Teacher: "+teacher.name
    }) 
    
    console.log(student)
});


// - Hamının şifrəsinin əvvəlinə 3 ədəd boşluq əlavə edin. String metod istifadə edin


students.forEach(student => {
    student.loginDetail.password="   "+student.loginDetail.password
   
    console.log(student)
});