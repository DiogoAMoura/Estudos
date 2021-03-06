#include <stdio.h>
#include <stdlib.h>

typedef struct{
    int dia, mes, ano;
}Data;

typedef struct{
    char nome[50];
    Data data;
}Pessoa;

typedef struct no{
    Pessoa p;
    struct no *proximo;
}No;

typedef struct{
    No *topo;
    int tam;
}Pilha;

void criar_pilha(Pilha *p){
    p->topo = NULL;
    p->tam = 0;
}

Pessoa ler_pessoa(){
    Pessoa p;

    printf("\nDigite o nome e data de nascimento [dd/mm/aaaa]: \n");
    scanf("%49[^\n]%d%d%d", p.nome, &p.data.dia, &p.data.mes, &p.data.ano);
    return p;
}

void imprimir_pessoa(Pessoa p){
    printf("\nNome: %s\tData: %d/%d/%d\n", p.nome, p.data.dia, p.data.mes, p.data.ano);
}
void empilhar(Pilha *p){
    No *novo = malloc(sizeof(No));

    if(novo){
        novo->p = ler_pessoa();
        novo->proximo = p->topo;
        p->topo = novo;
        p->tam++;

    }else printf("\nERROR\n");

}

No* desempilhar(Pilha *p){
    if(p->topo){
        No *remover = p->topo;
        p->topo = remover->proximo;
        p->tam--;
        return remover;
    }else printf("\nPilha vazia\n");

    return NULL;
}

void imprimir_pilha(Pilha *p){
    No *aux = p->topo;
    printf("\n--------PILHA---------\n");
    while(aux){
        imprimir_pessoa(aux->p);
        aux = aux->proximo;
    }
    printf("\n------FIM PILHA-------\n");
}

int main()
{
    No *remover;
    Pilha p;
    int opcao;

    criar_pilha(&p);

    do{
        printf("\nSair - 0\nEmpilhar - 1\nDesempilhar - 2\nImprimir - 3\n");
        scanf("%d", &opcao);
        getchar();

        switch(opcao){
            case 1: empilhar(&p); break;
            case 2: 
                remover = desempilhar(&p); 
                if(remover){
                    printf("\nElemento removido\n");
                    imprimir_pessoa(remover->p);
                    free(remover);
                }else printf("\nERROR ao remover elemento\n");
                break;
            case 3: imprimir_pilha(&p); break;
            default: if(opcao != 0) printf("Opcao invalida"); break;
        }

    }while(opcao != 0);

    return 0;
}