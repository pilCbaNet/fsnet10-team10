export class Login{
    email: string;
    pass: string;

    constructor(email: string, pass: string){
        this.email = email;
        this.pass = pass;
    }
}

export class CrearCuenta{
    nombre: string;
    apellido: string;
    nombreUsuario: string;
    email: string;
    CUIL: string;
    localidad: string;
    fechaNacimiento: string;
    pass: string;
    pass2: string;


    constructor(nombre: string, apellido: string, nombreUsuario: string, email: string, CUIL: string, localidad: string, fechaNacimiento: string, pass: string, pass2: string ){
        this.nombre = nombre;
        this.apellido = apellido;
        this.nombreUsuario = nombreUsuario;
        this.email = email;
        this.CUIL = CUIL;
        this.localidad = localidad;
        this.fechaNacimiento = fechaNacimiento;
        this.pass = pass;
        this.pass2 = pass2;

    }
}