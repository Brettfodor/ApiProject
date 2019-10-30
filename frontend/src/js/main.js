import Header from "./component/header";
import Footer from "./component/footer";

export default () =>
{
    Pagebuild();
};

function Pagebuild(){
    header();
    footer();
};

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header();
}
function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer();
}