let amigo = {
    nome: 'José',
    sexo: 'M',
    peso: 85.4,
    engordar(p=0){
        console.log('Engordou')
        this.peso += p
    }
}

amigo.engordar(2)
delete amigo.nome
amigo.nome = "Diogo"
console.log(`${amigo.nome} pesa ${amigo.peso}Kg`)
console.log(Object.keys(amigo))