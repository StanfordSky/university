function printFilms( arFilms, selector ) {
    const startTemplate = '<table style="width:80%;"><tr class="head_table"><td>Брэнд</td><td>Год выпуска первой модели</td><td>Форма деки</td><td>Страна</td><td>Тип звукоснимателей</td></tr>';
    const lileTemplate = '<tr><td>{{brand}}</td><td>{{year}}</td><td>{{body}}</td><td>{{country}}</td><td>{{type}}</td></tr>';
    const endTemplate = '</table>';
    
    let output = startTemplate;
    
    for (let item of arFilms) {
        let tmpLine;
        tmpLine = lileTemplate.replace('{{brand}}', item.brand);
        tmpLine = tmpLine.replace('{{year}}',     item.year);
        tmpLine = tmpLine.replace('{{body}}',      item.body);
        tmpLine = tmpLine.replace('{{country}}',   item.country);
        tmpLine = tmpLine.replace('{{type}}',   item.type);
        output += tmpLine;
    };
    
    output += endTemplate;
    $(selector).html(output);
    
    }

    function printFilters( arFilms, arProperties, selector ) {
        const startTemplate = '<br>{{name}}<br>';
        const lileTemplate  = '<label><input type="checkbox" id="{{name}}" name="{{prop}}" value="{{name}}">{{name}}</label><br>';
        const endTemplate   = '';
        let output = '';

        for (let prop in arProperties) {
            let tmpLine = startTemplate.replace('{{name}}', arProperties[prop]);
            let vals    = [];

            for (let film of films) {
            if (!vals.includes(film[prop])) {
                vals.push(film[prop]);
            }
        }
        
        vals.sort();
        vals.forEach(function(item) {
            tmpLine += lileTemplate.replace("{{prop}}", prop ).replaceAll("{{name}}",item);
        });
        
        output += tmpLine;
        
        };
        
        output += endTemplate;
        $(selector).html(output);
        
    }

    function readCurFilters(properties) {
        let result = [];

        for (let prop in properties) {
            let searchIDs = $("#filters input[name='"+prop+"']:checkbox:checked").map(function(){
            return $(this).val();
        }).get();
        
        result[prop] = searchIDs;
        }
        
        return result;
        
    }

    function applyFilters( data, filter, properties) {
        let result = [];

        for (let film of data) {
            let ok = true;
            for (let prop in properties) {
                if (!filter[prop].length)
                    continue;

                if (filter[prop].indexOf(film[prop]) == -1)
                    ok = false;
            }
            
            if (ok) {
                result.push(film);
            };
        }
    
        return result;
    }

    function getEmptyFilters(properties){
        let filters = [];

        for (let prop in properties) {
            let searchIDs = $("#filters input[name='"+prop+"']:not(:checked)").map(function(){
            return $(this).val();
            }).get();
        
            filters[prop] = searchIDs;
        }
        return filters;
    }
    

    function closeEmptyCheckBox(curFilter, filters, films, properties)
    {
    
        for(let prop in properties){
            for(let filter in filters[prop]){
                curFilter[prop].push(filters[prop][filter]);
                if(applyFilters( films, curFilter, properties).length === 0){
                    document.getElementById(filters[prop][filter]).setAttribute('disabled', 'true');
                }else{
                    document.getElementById(filters[prop][filter]).removeAttribute('disabled');
                }
                curFilter[prop].pop();
            }

        }
    }


    $(document).ready(function(){
        printFilms( films, '#elements' );
        printFilters( films, properties, '#filters' );

        $('#filters input').change(function()
        {
            let curFilter    = readCurFilters(properties);
            let filtredFilms = applyFilters( films, curFilter, properties);
            let unchecked    = getEmptyFilters(properties);
            closeEmptyCheckBox(curFilter, unchecked,films, properties);

            printFilms( filtredFilms, '#elements' );
        });
    });