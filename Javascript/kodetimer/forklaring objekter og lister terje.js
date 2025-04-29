const model = {
    app: {
        loggedInUser: null,
        currentPage: 'productDetailPage',
        displayMode: 'dark',
        language: 'no',
    },
    inputs: {
        shoppingCartPage: {
            items: [
                {
                    productId: 123,
                    count: 1,
                },
                {
                    productId: 124,
                    count: 2,
                },
            ],
        },
        productListPage: {
            searchText: null,
            sort: {
                field: 'price',
                isAscending: true,
            },
            layout: 'list',
        },
        productDetailPage: {
            productId: 123,
            zipCode: '3292',
            currentImageIndex: 0,

        },
    },
    // data
    shoppingCart: [
        {
            productId: 123,
            count: 1,
        },
    ],
    purchases: [

    ],
    products: [
        {
            id: 123,
            title: 'Svive Oberon switch Gaming Tastatur',
            description: 'Full størrelse, mekanisk, nordisk-layout, TTC switches, RGB, USB',
            beforePrice: null,
            price: 1319,
            stars: 4.5,
            variants: ['Brown', 'Red'],
            inStockCount: 50,
            images: [],
            brand: 1,
        },
        {
            id: 124,
            title: 'Svive Triton...',
            description: '60%....',
            beforePrice: 799,
            price: 499,
            stars: 3.5,
            variants: null,
            inStockCount: 50,
            images: [],
            brand: 1,
        },
    ],
    brands: [
        { id: 1, name: 'Svive', url: 'www.svive.com' },
        { id: 2, name: 'Logitech', url: 'www.logitech.com' },
    ],
};

/*
 - Per side: 
   1: Hvilke data vises her - og hvordan skal de ligge i 
      modellen for at vi skal kunne tegne opp siden?
   2: Hva kan brukeren gjøre på denne siden - og hvilke 
      endringer i modellen følger av det?
*/