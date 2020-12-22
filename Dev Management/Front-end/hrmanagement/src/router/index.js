import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      redirect: '/HRManagement'
    },
    {
      path: '/HRManagement',
      name: 'HRManagement',
      component:  () => import('../view/HRManagement'),
      children: [
        {
          path: '',
          redirect: '/Profile'
        },
        {
          path: '/Profile',
          name: 'Profile',
          component:  () => import('../view/HRManagement/Profile'),
        }

      ]
    },
  ]
})
