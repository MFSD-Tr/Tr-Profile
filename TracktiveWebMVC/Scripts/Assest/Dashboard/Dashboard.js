function PageLoad(pageName) {
    
    $("#dashboardBodyContent").load("http://localhost:55852/DashBoard/Category/?categoryName=" + pageName);

}


$(document).on('click', '#b', function () { alert("hello"); });