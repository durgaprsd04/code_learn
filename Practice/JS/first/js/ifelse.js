function testAge()
{
    var age=document.getElementById("agebox").value
    age1 = Number(age);
    
    docuspace=document.getElementById("mytestspace");
    if(age1>18)
    {
        docuspace.innerHTML="eligible for this";
    }
    else
    {
        docuspace.innerHTML="not eligible for this";
    }
}