var option = {
    tooltip: {
        trigger: 'axis',
        position: function (pt) {
            return [pt[0], '10%'];
        },
        formatter:function(params){
            var html = '';
            if(params.length>0){
                Xindex = params[0].dataIndex;
                Xname = params[0].name;
                Xvalue = params[0].value;
                html+='<span style="display:inline-block;margin-right:5px;border-radius:10px;width:9px;height:9px;background-color:#FFF;"></span>'
                html+='时间：'+params[0].name+'ms<br>';
                for ( var int = 0; int < params.length; int++) {
                    html+='<span style="display:inline-block;margin-right:5px;border-radius:10px;width:9px;height:9px;background-color:'+params[int].color+';"></span>'
                    html+=params[int].seriesName+'：'+params[int].data+'V<br>';
                }
            }
            return html;
        }
    },
    title: {
        left: 'center',
        text: 'AD采样数据',
    },
    toolbox: {
        feature: {
            dataZoom: {
                yAxisIndex: 'none'
            },
            restore: {},
            saveAsImage: {}
        }
    },
    xAxis: {
        type: 'category',
        boundaryGap: false,
        data: data0
    },
    yAxis: {
        type: 'value',
        boundaryGap: [0, '100%']
    },
    dataZoom: [{
        type: 'inside',
        start: 0,
        end: 10
    }, {
        start: 0,
        end: 10,
        handleIcon: 'M10.7,11.9v-1.3H9.3v1.3c-4.9,0.3-8.8,4.4-8.8,9.4c0,5,3.9,9.1,8.8,9.4v1.3h1.3v-1.3c4.9-0.3,8.8-4.4,8.8-9.4C19.5,16.3,15.6,12.2,10.7,11.9z M13.3,24.4H6.7V23h6.6V24.4z M13.3,19.6H6.7v-1.4h6.6V19.6z',
        handleSize: '80%',
        handleStyle: {
            color: '#fff',
            shadowBlur: 3,
            shadowColor: 'rgba(0, 0, 0, 0.6)',
            shadowOffsetX: 2,
            shadowOffsetY: 2
        }
    }],
    series: [
        {
            name:'AD1',
            type:'line',
            smooth:true,
            symbol: 'none',
            sampling: 'average',
            data: data1
        },
        {
            name:'AD2',
            type:'line',
            smooth:true,
            symbol: 'none',
            sampling: 'average',
            data: data2
        }
    ]
};
