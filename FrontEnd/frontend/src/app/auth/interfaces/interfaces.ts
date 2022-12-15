export interface Usuario{
    idUsuario    : string;
    nombreUsuario: string;
}

export interface SaldoResp {
    idCuenta:            number;
    saldo:               number;
    cvu:                 number;
    habilitado:          null;
    idUsuario:           number;
    idUsuarioNavigation: null;
    operacion:           any[];
}