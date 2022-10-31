
export class Transaction {
  id:number;
  description: string;
  type:string;
  status: string;
  cripto: number;
  typeCrypto: string;
  amount: number;
  typeMoney: string;
  date: string;
  constructor(id:number, description: string, type: string, status: string, cripto: number,
    typeCrypto: string, amount: number, typeMoney: string, date: string) {
      this.id = id;
      this.description = description;
      this.type = type;
      this.status = status;
      this.cripto = cripto;
      this.typeCrypto = typeCrypto;
      this.amount = amount;
      this.typeMoney = typeMoney;
      this.date = date
  }
}
