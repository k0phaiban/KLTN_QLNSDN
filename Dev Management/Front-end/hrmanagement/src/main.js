import Vue from 'vue'
import App from './App.vue'
import router from './router'
import ElementUI from 'element-ui';
import store from './store'
import './styles/index.scss';
import 'element-ui/lib/theme-chalk/index.css';
import 'devextreme/dist/css/dx.common.css';
import 'devextreme/dist/css/dx.light.css';
import './globalComponents';
import Popup from "./components/popup-notification/index.js";

Vue.config.productionTip = false
Vue.use(Popup);
Vue.use(ElementUI);
const moment = require('moment')
require('moment/locale/es')
 
Vue.use(require('vue-moment'), {
    moment
})

new Vue({
  render: h => h(App),
  router,
  store
}).$mount('#app')
