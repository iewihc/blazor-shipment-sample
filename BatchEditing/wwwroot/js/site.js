function alertMessage(message) {
    alert(message+"保存成功！")
    //document.getElementById('myId').innerText="123123123123123123"
}



function getDanmu(message) {
    let wrapper = document.getElementById('wrapper')
    let dom = document.createElement('span');
    let doms = [];
    let hasPosition = [];
    wrapper.appendChild(dom);
    dom.className = 'right';
    let x =Math.floor(Math.random()*20)
    dom.style.top = x * 20 + 'px';
    doms.push(dom);
    //
    dom.innerText = "使用者:"+message;
    dom.style.transform = `translateX(${-dom.clientWidth}px)`;
    dom.className = 'left';
    //hasPosition[channel] = false;
    //setTimeout(() => {
    //    hasPosition[channel] = true;
    //}, dom.clientWidth * 10 + 1000);
}
        


    //shootDanmu


